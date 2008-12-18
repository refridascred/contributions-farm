-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, ratio, rank, level) VALUES ('legacy', 52.54, 62, 34);
INSERT INTO layout_items (owner, ratio, rank, level) VALUES ('stable', 45.65, 30, 3);
