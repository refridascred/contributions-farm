-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (active, rank, score, owner) VALUES (21, 4, 11.51, 'cached');
INSERT INTO layout_items (active, rank, score, owner) VALUES (18, 85, 74.94, 'open');
INSERT INTO layout_items (active, rank, score, owner) VALUES (31, 95, 41.6, 'cached');
