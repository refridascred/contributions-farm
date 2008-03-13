-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, ratio, level, rank) VALUES ('staging', 14.83, 72, 60);
INSERT INTO layout_items (owner, ratio, level, rank) VALUES ('fallback', 80.71, 56, 8);
