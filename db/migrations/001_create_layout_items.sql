-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, level, count, weight) VALUES ('standard', 88, 28, 24.77);
INSERT INTO layout_items (owner, level, count, weight) VALUES ('latest', 95, 95, 59.41);
