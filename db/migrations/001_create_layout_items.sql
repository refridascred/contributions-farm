-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, weight, score, owner) VALUES (99, 2.14, 17.11, 'cached');
INSERT INTO layout_items (level, weight, score, owner) VALUES (76, 88.23, 32.87, 'standard');
