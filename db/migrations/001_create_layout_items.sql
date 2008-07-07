-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    rank INTEGER,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, level, rank, token) VALUES ('fallback', 94, 99, 'local');
INSERT INTO layout_items (label, level, rank, token) VALUES ('open', 11, 26, 'local');
INSERT INTO layout_items (label, level, rank, token) VALUES ('staging', 3, 18, 'open');
