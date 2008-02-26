-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, owner, level, rank) VALUES (82.66, 'blue', 76, 80);
INSERT INTO layout_items (ratio, owner, level, rank) VALUES (58.03, 'standard', 30, 24);
INSERT INTO layout_items (ratio, owner, level, rank) VALUES (78.02, 'primary', 34, 14);
