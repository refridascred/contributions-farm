-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, weight, owner, score, active) VALUES (7, 43.93, 'cached', 97.06, 62);
INSERT INTO layout_items (rank, weight, owner, score, active) VALUES (2, 53.07, 'edge', 57.06, 66);
INSERT INTO layout_items (rank, weight, owner, score, active) VALUES (34, 10.75, 'strict', 84.23, 66);
