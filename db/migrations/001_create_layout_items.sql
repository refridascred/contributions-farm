-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, owner, active, rank) VALUES (1, 'open', 74, 70);
INSERT INTO layout_items (level, owner, active, rank) VALUES (53, 'latest', 91, 97);
INSERT INTO layout_items (level, owner, active, rank) VALUES (43, 'primary', 3, 37);
