-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, level, owner, score) VALUES (10.99, 58, 'eu-west', 56.12);
INSERT INTO layout_items (weight, level, owner, score) VALUES (91.25, 95, 'open', 15.06);
