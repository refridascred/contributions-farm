-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, owner, label, level) VALUES (13, 'legacy', 'open', 83);
INSERT INTO layout_items (rank, owner, label, level) VALUES (42, 'local', 'standard', 18);
INSERT INTO layout_items (rank, owner, label, level) VALUES (54, 'stable', 'blue', 48);
