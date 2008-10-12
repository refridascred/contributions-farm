-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, owner, ratio) VALUES (24, 'strict', 36.35);
INSERT INTO layout_items (rank, owner, ratio) VALUES (66, 'local', 95.09);
INSERT INTO layout_items (rank, owner, ratio) VALUES (83, 'blue', 92.86);
