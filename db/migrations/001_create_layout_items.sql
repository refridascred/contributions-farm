-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, label, token, active, level) VALUES (2, 'stable', 'latest', 96, 42);
INSERT INTO layout_items (rank, label, token, active, level) VALUES (58, 'cached', 'blue', 22, 9);
