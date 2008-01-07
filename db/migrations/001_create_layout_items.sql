-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, score, label, rank, token) VALUES (50.56, 75.42, 'standard', 27, 'open');
INSERT INTO layout_items (ratio, score, label, rank, token) VALUES (31.54, 98.33, 'cached', 74, 'staging');
INSERT INTO layout_items (ratio, score, label, rank, token) VALUES (56.57, 60.26, 'green', 35, 'latest');
