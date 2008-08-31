-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, token, ratio) VALUES (54.86, 'latest', 22.81);
INSERT INTO layout_items (weight, token, ratio) VALUES (60.5, 'primary', 40.51);
