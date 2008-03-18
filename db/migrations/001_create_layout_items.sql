-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, ratio, weight) VALUES ('open', 22.35, 86.57);
INSERT INTO layout_items (token, ratio, weight) VALUES ('local', 26.24, 14.12);
INSERT INTO layout_items (token, ratio, weight) VALUES ('standard', 69.13, 58.44);
