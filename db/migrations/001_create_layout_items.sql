-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, label, rank, ratio, state) VALUES ('stable', 'stable', 69, 6.52, 'legacy');
INSERT INTO layout_items (token, label, rank, ratio, state) VALUES ('edge', 'fallback', 38, 40.16, 'blue');
