-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (count, weight, owner, level) VALUES (91, 92.74, 'eu-west', 29);
INSERT INTO layout_items (count, weight, owner, level) VALUES (3, 96.56, 'latest', 80);
INSERT INTO layout_items (count, weight, owner, level) VALUES (84, 71.41, 'open', 58);
