-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, weight, count, ratio) VALUES ('eu-west', 17.97, 61, 86.63);
INSERT INTO layout_items (token, weight, count, ratio) VALUES ('standard', 7.81, 84, 84.5);
INSERT INTO layout_items (token, weight, count, ratio) VALUES ('eu-west', 79.7, 98, 70.16);
