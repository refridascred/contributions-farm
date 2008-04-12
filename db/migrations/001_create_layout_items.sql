-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, rank, owner, active) VALUES (29.05, 35, 'legacy', 60);
INSERT INTO layout_items (ratio, rank, owner, active) VALUES (80.1, 97, 'green', 6);
INSERT INTO layout_items (ratio, rank, owner, active) VALUES (20.35, 93, 'edge', 16);
