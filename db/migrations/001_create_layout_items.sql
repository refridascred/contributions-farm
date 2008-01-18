-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, owner, level, count) VALUES (98.86, 'strict', 29, 17);
INSERT INTO layout_items (weight, owner, level, count) VALUES (9.89, 'latest', 20, 67);
INSERT INTO layout_items (weight, owner, level, count) VALUES (62.06, 'eu-west', 36, 58);
