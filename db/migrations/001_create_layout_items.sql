-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, rank, label, active, token) VALUES (64.38, 71, 'staging', 28, 'cached');
INSERT INTO layout_items (ratio, rank, label, active, token) VALUES (66.13, 3, 'cached', 71, 'open');
