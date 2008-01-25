-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, active, score) VALUES (65, 67, 59.55);
INSERT INTO layout_items (rank, active, score) VALUES (35, 7, 7.41);
INSERT INTO layout_items (rank, active, score) VALUES (63, 50, 41.91);
