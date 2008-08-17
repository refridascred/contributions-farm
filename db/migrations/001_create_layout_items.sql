-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (count, weight, state, token, region) VALUES (28, 4.86, 'stable', 'primary', 'green');
INSERT INTO layout_items (count, weight, state, token, region) VALUES (54, 31.0, 'standard', 'staging', 'cached');
INSERT INTO layout_items (count, weight, state, token, region) VALUES (7, 26.94, 'open', 'stable', 'stable');
