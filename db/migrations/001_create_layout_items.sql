-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, token, weight) VALUES (27.51, 'standard', 5.56);
INSERT INTO layout_items (ratio, token, weight) VALUES (46.79, 'open', 94.57);
