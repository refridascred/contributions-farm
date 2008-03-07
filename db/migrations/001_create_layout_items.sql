-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, weight, rank, count, level) VALUES ('local', 3.24, 27, 29, 49);
INSERT INTO layout_items (owner, weight, rank, count, level) VALUES ('open', 4.37, 86, 13, 46);
INSERT INTO layout_items (owner, weight, rank, count, level) VALUES ('eu-west', 7.43, 85, 96, 64);
