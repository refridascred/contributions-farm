-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, weight, owner) VALUES (80, 56.0, 'edge');
INSERT INTO layout_items (rank, weight, owner) VALUES (4, 51.26, 'open');
INSERT INTO layout_items (rank, weight, owner) VALUES (18, 62.53, 'green');
