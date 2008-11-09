-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, ratio, region) VALUES ('staging', 89.05, 'legacy');
INSERT INTO layout_items (state, ratio, region) VALUES ('blue', 48.36, 'fallback');
