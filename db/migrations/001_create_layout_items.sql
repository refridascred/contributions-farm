-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, rank, owner, ratio) VALUES (51, 96, 'blue', 35.97);
INSERT INTO layout_items (count, rank, owner, ratio) VALUES (19, 8, 'open', 68.12);
INSERT INTO layout_items (count, rank, owner, ratio) VALUES (72, 62, 'strict', 2.4);
