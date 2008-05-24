-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (token, label, owner, rank, level) VALUES ('staging', 'local', 'strict', 33, 41);
INSERT INTO layout_items (token, label, owner, rank, level) VALUES ('latest', 'strict', 'latest', 79, 56);
