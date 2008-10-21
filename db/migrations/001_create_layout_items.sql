-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, rank, active, owner) VALUES (36.61, 89, 76, 'stable');
INSERT INTO layout_items (weight, rank, active, owner) VALUES (79.7, 95, 49, 'standard');
INSERT INTO layout_items (weight, rank, active, owner) VALUES (93.93, 67, 95, 'strict');
