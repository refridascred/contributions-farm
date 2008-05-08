-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, owner, score, weight) VALUES (43, 'cached', 64.81, 2.03);
INSERT INTO layout_items (rank, owner, score, weight) VALUES (17, 'edge', 47.46, 73.83);
