-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, owner, score, rank) VALUES ('strict', 'green', 7.45, 40);
INSERT INTO layout_items (label, owner, score, rank) VALUES ('green', 'edge', 35.46, 16);
INSERT INTO layout_items (label, owner, score, rank) VALUES ('local', 'edge', 69.58, 5);
