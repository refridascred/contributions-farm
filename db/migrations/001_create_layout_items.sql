-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, owner, ratio, label) VALUES (33, 'staging', 71.78, 'blue');
INSERT INTO layout_items (rank, owner, ratio, label) VALUES (36, 'staging', 19.43, 'open');
