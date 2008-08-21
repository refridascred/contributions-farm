-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, owner, score, count) VALUES (33.86, 'open', 49.26, 65);
INSERT INTO layout_items (weight, owner, score, count) VALUES (59.72, 'open', 6.78, 92);
