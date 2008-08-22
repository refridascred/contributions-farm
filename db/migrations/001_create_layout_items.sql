-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (score, region, state, label) VALUES (50.4, 'stable', 'open', 'staging');
INSERT INTO layout_items (score, region, state, label) VALUES (93.19, 'open', 'green', 'stable');
INSERT INTO layout_items (score, region, state, label) VALUES (88.07, 'legacy', 'strict', 'primary');
