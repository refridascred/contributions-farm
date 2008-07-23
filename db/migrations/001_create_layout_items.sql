-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, score, active, level) VALUES (4, 98.91, 23, 34);
INSERT INTO layout_items (rank, score, active, level) VALUES (64, 33.3, 47, 65);
INSERT INTO layout_items (rank, score, active, level) VALUES (95, 43.22, 22, 20);
