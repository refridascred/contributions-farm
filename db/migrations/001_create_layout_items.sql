-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (level, rank, label, score, ratio) VALUES (96, 9, 'open', 22.81, 65.66);
INSERT INTO layout_items (level, rank, label, score, ratio) VALUES (90, 79, 'local', 19.64, 78.28);
INSERT INTO layout_items (level, rank, label, score, ratio) VALUES (97, 8, 'strict', 45.95, 69.74);
