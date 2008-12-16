-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, level, weight, rank, ratio) VALUES ('green', 11, 97.73, 66, 31.0);
INSERT INTO layout_items (owner, level, weight, rank, ratio) VALUES ('staging', 86, 71.13, 78, 30.82);
INSERT INTO layout_items (owner, level, weight, rank, ratio) VALUES ('latest', 52, 52.08, 28, 10.34);
