-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, score, count, label, rank) VALUES ('staging', 8.77, 87, 'stable', 16);
INSERT INTO layout_items (owner, score, count, label, rank) VALUES ('legacy', 96.75, 38, 'latest', 68);
INSERT INTO layout_items (owner, score, count, label, rank) VALUES ('local', 35.07, 92, 'strict', 41);
