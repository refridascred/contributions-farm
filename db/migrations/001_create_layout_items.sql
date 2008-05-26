-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, score, ratio, active) VALUES ('staging', 58.62, 70.97, 41);
INSERT INTO layout_items (owner, score, ratio, active) VALUES ('strict', 79.78, 23.12, 61);
INSERT INTO layout_items (owner, score, ratio, active) VALUES ('staging', 5.43, 35.17, 88);
