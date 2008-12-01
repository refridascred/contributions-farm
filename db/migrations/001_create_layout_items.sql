-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, rank, owner, token) VALUES (68, 68, 'green', 'staging');
INSERT INTO layout_items (level, rank, owner, token) VALUES (98, 14, 'latest', 'green');
INSERT INTO layout_items (level, rank, owner, token) VALUES (96, 86, 'latest', 'green');
