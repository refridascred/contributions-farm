-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (rank, state, label, region) VALUES (92, 'fallback', 'legacy', 'blue');
INSERT INTO layout_items (rank, state, label, region) VALUES (12, 'strict', 'primary', 'latest');
