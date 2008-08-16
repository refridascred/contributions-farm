-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, token, rank, ratio) VALUES (73.51, 'open', 88, 64.58);
INSERT INTO layout_items (score, token, rank, ratio) VALUES (18.09, 'staging', 95, 50.37);
INSERT INTO layout_items (score, token, rank, ratio) VALUES (10.74, 'open', 60, 30.66);
