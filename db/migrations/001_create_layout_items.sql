-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, active, level, rank, ratio) VALUES ('eu-west', 72, 78, 72, 26.97);
INSERT INTO layout_items (state, active, level, rank, ratio) VALUES ('fallback', 5, 80, 96, 5.15);
