-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, rank, ratio, label, state) VALUES ('eu-west', 53, 30.78, 'stable', 'green');
INSERT INTO layout_items (token, rank, ratio, label, state) VALUES ('stable', 17, 87.09, 'green', 'strict');
