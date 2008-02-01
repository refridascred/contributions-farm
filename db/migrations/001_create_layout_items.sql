-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, weight, count, score) VALUES ('eu-west', 14.55, 57, 75.84);
INSERT INTO layout_items (owner, weight, count, score) VALUES ('green', 4.94, 15, 79.0);
INSERT INTO layout_items (owner, weight, count, score) VALUES ('eu-west', 88.51, 5, 19.15);
