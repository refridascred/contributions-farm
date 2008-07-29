-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (rank, label, count, weight, token) VALUES (69, 'eu-west', 68, 31.3, 'open');
INSERT INTO layout_items (rank, label, count, weight, token) VALUES (46, 'fallback', 1, 73.15, 'fallback');
