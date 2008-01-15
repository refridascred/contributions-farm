-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, owner, weight, region) VALUES (70, 'strict', 71.55, 'green');
INSERT INTO layout_items (rank, owner, weight, region) VALUES (9, 'open', 38.11, 'staging');
INSERT INTO layout_items (rank, owner, weight, region) VALUES (77, 'stable', 3.99, 'stable');
