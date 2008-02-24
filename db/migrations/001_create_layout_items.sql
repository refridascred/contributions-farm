-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (state, weight, rank, score, active) VALUES ('stable', 42.08, 95, 77.46, 16);
INSERT INTO layout_items (state, weight, rank, score, active) VALUES ('blue', 24.43, 24, 16.37, 97);
