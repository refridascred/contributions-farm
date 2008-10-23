-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, rank, level, weight) VALUES ('open', 93, 85, 73.66);
INSERT INTO layout_items (owner, rank, level, weight) VALUES ('primary', 3, 48, 21.98);
INSERT INTO layout_items (owner, rank, level, weight) VALUES ('staging', 23, 0, 80.85);
