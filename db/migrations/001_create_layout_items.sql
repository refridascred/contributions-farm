-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (owner, active, rank) VALUES ('legacy', 65, 86);
INSERT INTO layout_items (owner, active, rank) VALUES ('latest', 59, 7);
INSERT INTO layout_items (owner, active, rank) VALUES ('staging', 95, 77);
