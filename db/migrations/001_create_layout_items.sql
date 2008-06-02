-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, weight, token, region) VALUES (46, 47.71, 'standard', 'local');
INSERT INTO layout_items (rank, weight, token, region) VALUES (91, 85.06, 'cached', 'local');
