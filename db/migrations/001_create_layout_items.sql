-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, token, weight, owner, rank) VALUES (39, 'fallback', 18.2, 'blue', 59);
INSERT INTO layout_items (count, token, weight, owner, rank) VALUES (13, 'standard', 54.66, 'green', 86);
INSERT INTO layout_items (count, token, weight, owner, rank) VALUES (91, 'latest', 58.84, 'stable', 92);
