-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, rank, owner, ratio) VALUES (91.71, 76, 'standard', 96.05);
INSERT INTO layout_items (weight, rank, owner, ratio) VALUES (3.96, 1, 'primary', 79.51);
INSERT INTO layout_items (weight, rank, owner, ratio) VALUES (36.16, 26, 'green', 60.02);
