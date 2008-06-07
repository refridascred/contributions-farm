-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, token, state, region, label) VALUES (73.2, 'stable', 'standard', 'fallback', 'latest');
INSERT INTO layout_items (weight, token, state, region, label) VALUES (33.16, 'local', 'primary', 'stable', 'blue');
INSERT INTO layout_items (weight, token, state, region, label) VALUES (98.65, 'stable', 'standard', 'legacy', 'legacy');
