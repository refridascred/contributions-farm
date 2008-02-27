-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, active, score) VALUES (60, 3, 43.75);
INSERT INTO layout_items (rank, active, score) VALUES (46, 90, 56.02);
INSERT INTO layout_items (rank, active, score) VALUES (78, 37, 9.63);
