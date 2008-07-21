-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (active, owner, ratio, rank) VALUES (35, 'eu-west', 5.99, 73);
INSERT INTO layout_items (active, owner, ratio, rank) VALUES (52, 'stable', 71.81, 18);
INSERT INTO layout_items (active, owner, ratio, rank) VALUES (38, 'primary', 77.44, 65);
