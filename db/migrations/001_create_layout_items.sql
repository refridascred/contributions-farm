-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (rank, level, label) VALUES (73, 44, 'strict');
INSERT INTO layout_items (rank, level, label) VALUES (40, 4, 'local');
