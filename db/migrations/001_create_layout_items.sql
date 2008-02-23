-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, weight, active, token, count) VALUES ('blue', 34.18, 70, 'latest', 12);
INSERT INTO layout_items (label, weight, active, token, count) VALUES ('fallback', 63.58, 52, 'standard', 30);
INSERT INTO layout_items (label, weight, active, token, count) VALUES ('green', 51.72, 33, 'eu-west', 11);
