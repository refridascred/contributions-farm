-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, ratio, label) VALUES ('fallback', 11.47, 'blue');
INSERT INTO layout_items (state, ratio, label) VALUES ('strict', 69.11, 'legacy');
INSERT INTO layout_items (state, ratio, label) VALUES ('local', 64.95, 'legacy');
