-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, rank, level, score) VALUES ('standard', 16, 2, 54.34);
INSERT INTO layout_items (label, rank, level, score) VALUES ('eu-west', 62, 34, 34.54);
INSERT INTO layout_items (label, rank, level, score) VALUES ('cached', 34, 67, 52.89);
