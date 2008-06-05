-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, token, ratio, rank, state) VALUES ('latest', 'legacy', 58.01, 37, 'strict');
INSERT INTO layout_items (owner, token, ratio, rank, state) VALUES ('open', 'primary', 4.84, 44, 'standard');
