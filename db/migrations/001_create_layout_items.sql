-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, token, ratio) VALUES (84.9, 'eu-west', 59.21);
INSERT INTO layout_items (weight, token, ratio) VALUES (55.83, 'staging', 33.78);
